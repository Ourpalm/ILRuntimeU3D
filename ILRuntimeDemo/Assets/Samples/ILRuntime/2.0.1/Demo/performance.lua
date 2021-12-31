local MandelbrotCheck = function(workX, workY)
	return ((workX * workX) + (workY * workY)) < 4.0
end
local GameObject = CS.UnityEngine.GameObject
local Vector3 = CS.UnityEngine.Vector3
local Quaternion = CS.UnityEngine.Quaternion
function TestMandelbrot(sb)
	local data = 0.0
	local iterations = 4
	local width = 64
	local height = 64
	local _os_t = os.clock
	local _ct = _os_t()
	for i = 1, iterations do
		local left = -2.1
		local right = 1.0
		local top = -1.3
		local bottom = 1.3
		local deltaX = (right - left) / width
		local deltaY = (bottom - top) / height
		local coordinateX = left
		for x = 1, width do
			local coordinateY = top
			for y = 1, height do
				local workX = 0
				local workY = 0
				local counter = 0
				--while(counter < 255 and MandelbrotCheck(workX, workY))
				while(counter < 255 and CS.Performance.MandelbrotCheck(workX, workY))				
				do
					counter = counter + 1
					local newX = (workX * workX) - (workY * workY) + coordinateX
					workY = 2 * workX * workY + coordinateY
                    workX = newX;
				end
				
				data = workX + workY
                coordinateY = coordinateY + deltaY
			end
			coordinateX = coordinateX + deltaX
		end
	end
	local _d =  _os_t()  - _ct
	sb:AppendLine("res="..data..", time:".._d*1000);
end

function Test0(sb)
	local t = os.clock()
	local go = GameObject("t")
	local transform = go.transform
	
	for i = 1, 2000000 do
		transform.position = transform.position
	end
	GameObject.Destroy(go)
	sb:AppendLine("time="..(os.clock()-t)*1000)
end

function Test1(sb)
	local t = os.clock()
	local go = GameObject("t")
	local transform = go.transform
	
	for i = 1, 2000000 do
		transform:Rotate(Vector3.up, 1)
	end
	
	GameObject.Destroy(go)
	sb:AppendLine("time="..(os.clock()-t)*1000)
end

function Test2(sb)
	local t = os.clock()
	
	for i = 1, 2000000 do
		local v = Vector3(i, i, i)
		local x,y,z = v.x, v.y, v.z
	end
	
	sb:AppendLine("time="..(os.clock()-t)*1000)
end

function Test3(sb)
	local t = os.clock()
	
	for i = 1, 20000 do
		local go = GameObject()
		GameObject.Destroy(go)
	end
	
	sb:AppendLine("time="..(os.clock()-t)*1000)
end

function Test4(sb)
	local t = os.clock()
	local tp = typeof(CS.UnityEngine.SkinnedMeshRenderer)
	
	for i = 1, 20000 do
		local go = GameObject()
		go:AddComponent(tp)
		local c = go:GetComponent(tp)
		c.receiveShadows = false
		GameObject.Destroy(go)
	end
	
	sb:AppendLine("time="..(os.clock()-t)*1000)

end

function Test5(sb)
	local t = os.clock()
	
	for i = 1, 2000000 do
		local p = CS.UnityEngine.Input.mousePosition
	end
	
	sb:AppendLine("time="..(os.clock()-t)*1000)
end

function Test6(sb)
	local t = os.clock()
	
	for i = 1, 2000000 do
		local v = Vector3(i, i, i)
		Vector3.Normalize(v)
	end
	
	sb:AppendLine("time="..(os.clock()-t)*1000)
end

function Test7(sb)
	local t = os.clock()
	
	for i = 1, 2000000 do
		local q1 = Quaternion.Euler(i, i, i)
		local q2 = Quaternion.Euler(i * 2, i * 2, i * 2)
		Quaternion.Slerp(Quaternion.identity, q1, 0.5)
	end
	
	sb:AppendLine("time="..(os.clock()-t)*1000)
end

function Test8(sb)
	local total = 0
	local t = os.clock()
	
	for i = 1, 2000000 do
		total = total + i - (i / 2) * (i + 3) / (i + 5)
	end
	
	sb:AppendLine("res="..total..",time="..(os.clock()-t)*1000)
end

function Test9(sb)
	local array = {}
	for i = 1, 1024 do
		array[i] = i
	end
	
	local total = 0
	local t = os.clock()
	
	for j = 1, 20000 do
		for i = 1, 1024 do
			total = total + array[i]
		end
	end
	
	sb:AppendLine("res="..total..",time="..(os.clock()-t)*1000)
end

function Test10(sb)
	local t = os.clock()
	local go = GameObject("t")
	local transform = go.transform
	
	for i = 1, 2000000 do
		CS.Performance.TestFunc1(1, "123", transform)
	end
	
	GameObject.Destroy(go)
	sb:AppendLine("time="..(os.clock()-t)*1000)
end

function Test11(sb)
	local t = os.clock()
	
	local c = function(o, x)
		local r = o + x
	end
	
	for i = 1, 1000000, 1 do
		local a = Vector3(1, 2, 3)
		local b = Vector3(4, 5, 6)
		c(a,b)
	end
	
	sb:AppendLine("time="..(os.clock()-t)*1000)
end