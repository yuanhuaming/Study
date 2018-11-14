
#使用键-值（key-value）存储，具有极快的查找速度。

d = {'Michael': 95, 'Bob': 75, 'Tracy': 85}
print(d['Michael'])
if ("Tom" in d)==False:
    d["Tom"]=100
print(d.get("Tom"))




#set和dict类似，也是一组key的集合，但不存储value，key不允许重复
s1 = set([1, 1, 2, 2, 3, 3])
print(s1)
s2 = set([2, 3, 4])
print(s1 & s2)  #交集
print(s1 | s2)  #并集