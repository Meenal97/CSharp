class ThirdMax
  def thirdmax arr
    return arr[-1] if arr.length < 3
  end
end
t = ThirdMax.new
puts t.thirdmax([2, 1])