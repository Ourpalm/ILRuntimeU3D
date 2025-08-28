using ILRuntime.Hybrid;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ILRuntime.Runtime.Enviorment
{
    public class HybridPatchManager
    {
        public const int HASH_INFO_FILE_MAGIC = 0x38688321;
        public const int PATCH_FILE_MAGIC = 0x38688323;
        public const int VERSION = 1;
        Dictionary<string, AssemblyPatch> patches = new Dictionary<string, AssemblyPatch>();

        HybridPatchManager(Stream stream)
        {
            BinaryReader br=new BinaryReader(stream);
            if (br.ReadInt32() != PATCH_FILE_MAGIC)
                throw new NotSupportedException("Wrong Magic");
            if (br.ReadInt32() != VERSION)
                throw new NotSupportedException("Wrong Version");

            int cnt = br.ReadInt32();
            for (int i = 0; i < cnt; i++)
            {
                var patch = AssemblyPatch.LoadFromStream(stream);
                if (patch.Name.Contains(','))
                    patches[patch.Name.Substring(0, patch.Name.IndexOf(','))] = patch;
                patches[patch.Name] = patch;
            }
        }

        public static HybridPatchManager LoadFromStream(Stream stream)
        {
            HybridPatchManager res = new HybridPatchManager(stream);
            return res;
        }

        public bool CanApplyPatch(Assembly asm)
        {
            if (patches.TryGetValue(asm.FullName, out var patch))
            {
                return patch.CanApplyPatch(asm);
            }
            else
                return false;
        }

        public void ApplyPatch(Assembly asm, Enviorment.AppDomain app)
        {
            if(patches.TryGetValue(asm.FullName, out var patch))
            {
                patch.PatchAssembly(asm, app);
            }
        }
    }
}
