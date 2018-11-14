
#tuple元组。一旦初始化就不能修改
#所谓的“不变”是说，tuple的每个元素，指向永远不变。

# -*- coding: utf-8 -*-


classmates = ('Michael', 'Bob', 'Tracy')
print('classmates =', classmates)
print('len(classmates) =', len(classmates))
print('classmates[0] =', classmates[0])
print('classmates[1] =', classmates[1])
print('classmates[2] =', classmates[2])
print('classmates[-1] =', classmates[-1])

# cannot modify tuple:
classmates[0] = 'Adam'