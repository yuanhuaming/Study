
x1 = input("请输入第一个元素：")
x2 = input("请输入第二个元素: ")
x3 = input("请输入第三个元素: ")
x4 = input("请输入第四个元素: ")
x5 = input("请输入第五个元素: ")


xArr =[x1,x2,x3,x4,x5] 

print ("结果为： ",xArr)
temp=0

for x in range(len(xArr)):
    for y in range(x+1,len(xArr)):
        if xArr[x]>xArr[y]:
           temp=xArr[x]
           xArr[x] = xArr[y]
           xArr[y]=temp

    



#输出排序结果
 
print ("按升序排序结果为： ",xArr)
