
#值传递
#def func(x):
#    print ('x is', x)
#    x = 2
#    print ('changed local x to', x)
##main
#x = 50
#func(x)
#print ('x is still', x)



#def func2():
#    global x
#    print ('x is', x)
#    x = 2
#    print ('changed local x to', x)
##main
#x = 50
#func2()
#print ('x is still', x)


#def func():
#    global x
#    x = 2
#    print ('x=', x)
##main
#func()
#print ('x=', x)

def func_1(*pa,**dic):
    print (pa)
    print (dic)
#main
func_1(1,2,3,a=1,b=2)



########################### 
def func1(a, b, c):
    return a+b+c
def func2(a, b, c, d):
    return a+b+c+d
#main
tu=(1, 2, 3)
s=func1(*tu)
print(s)

li=[1, 2, 3]
s=func2(9, *li)
print(s)
