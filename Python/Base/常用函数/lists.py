

#list是一种有序的集合，可以随时添加和删除其中的元素。
#list是可以修改的。这种修改，不是复制一个新的地址，而是在原地址进行修改。


#索引(index)和切片
arr = "qiwsir.github.io".split(".")
print("索引(index)和切片",arr[2],arr[1:3])

#连接两个序列
x=['python', 'java', 'c++']
y=[1, 2, 3, 4, 5, 6]
z=['C#','swift']
print("连接两个序列",x+y)  #list里面的元素的数据类型可以不同
print("extend",x.extend(z))  #吧Z追加到X列表中


#*，重复元素
print("连接两个序列",x*3)


#追加元素
x.append(".net")
print("追加元素:append",x)
x.insert(1,"golang")
print("追加元素:insert",x)

#比较
print("比较",min(x),max(y))

#x在该 list 中出现多少次 list.count(x)
print("某个元素在该 list 中出现多少次",x.count("python"))


#删除
x.remove("swift")
#删除list末尾的元素，用pop()方法
#删除指定位置的元素，用pop(i)方法，其中i是索引位置
print("删除",x,x.pop(1))


#替换元素
x[1] = "NULL"
print(x)

#list元素也可以是另一个list
s = ['python', 'java', x, 'scheme']
print(s)



L = [
    ['Apple', 'Google', 'Microsoft'],
    ['Java', 'Python', 'Ruby', 'PHP'],
    ['Adam', 'Bart', 'Lisa']
]

# 打印Apple:
print(L[0][0])
# 打印Python:
print(L[1][1])
# 打印Lisa:
print(L[2][2])
print(L[2][-1])