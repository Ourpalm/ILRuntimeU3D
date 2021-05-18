local MandelbrotCheck = function(workX, workY)
	return ((workX * workX) + (workY * workY)) < 4.0
end
local _test2 = function(v)
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
				while(counter < 255 and MandelbrotCheck(workX, workY))
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
	v = v or 100000
	local _d =  _os_t()  - _ct
	print("data:",data)
	print("ses:",_d)
end
_test2()