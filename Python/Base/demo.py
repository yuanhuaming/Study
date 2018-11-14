import math


def my_abs(x):
   if not isinstance(x, (int, float)):
        raise TypeError('bad operand type')
   if x >= 0:
        return x
   else:
        return -x
    

#空函数
def nop():
    pass


#返回多个值
def move(x, y, step, angle=0):
    nx = x + step * math.cos(angle)
    ny = y - step * math.sin(angle)
    return nx, ny


#*args是可变参数，args接收的是一个tuple；
#**kw是关键字参数，kw接收的是一个dict。
# 可变参数
def sum(*numbers):
    result=0;
    for x in numbers:
       result = result+x
    return result;

def power(x,n):
    return math.pow(x,n)


print(sum(1,2))

print(power(1,2))



print(my_abs(-11))

x, y = move(100, 100, 60, math.pi / 6)
print(x,y)

