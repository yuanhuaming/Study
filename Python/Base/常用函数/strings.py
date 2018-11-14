#!/usr/bin/env python3
# -*- coding: utf-8 -*-


#string的修改，会复制一个新的地址，和list的区别


# ASCII 码转换
print("ASCII 码转换：",ord('a') ,chr(97))
print("16进制转码：", '\u4e2d\u6587')
print('ABC'.encode('ascii'),'中文'.encode('utf-8'))
print(b'ABC'.decode('ascii'),b'\xe4\xb8\xad\xe6\x96\x87'.decode('utf-8'))

#字符串比较函数
var1 = "abde"
print("比较函数",max(var1) ,min(var1))

#字符串是否存在匹配值
print("字符串是否存在匹配值","a" in var1)

#字符串长度
print("字符串长度", len(var1))

#索引(index)和切片
x="abcdefghijklmn"
print(x.index("i"))  #找到其在字符串中的索引值
print(x[3],x[1:3] ,x[2:],x[:4])  
print(x[::-1] )  #字符串反转

#====================================================================
#占位符	替换内容
#%d	整数
#%f	浮点数
#%s	字符串
#%x	十六进制整数
#字符串占位符替换
print("字符串占位符", "I love %s" % "python")
print("字符串", "I love {} , love {} too".format("python",".net"))
print("浮点数占位符","工资 %.2f ,整数 %d" %(123.453,123))   #.2f  小数点后2位
print('%2d-%02d' % (3, 1))
print('%.1f%%' % (85/72*100))
#==============================================================
#字符串是否字母
print("字符串是否字母","python".isalpha(),"2python".isalpha())

#字符串分割
x = "i love python"
print("字符串分割",x.split(" "))

#去掉字符串的空格
print("去掉字符串的空格"," a ".strip(), " b ".lstrip(), " c ".lstrip())

#大小写的转换
print("字母小写","ABCs".lower(),"ABCs".islower())
print("每个词的首字母大写","i love python".title(),"I Love".istitle())
print("首字母大写","love python".capitalize())
print("字母大写","i love python".upper(),"I LOVE".isupper())

#拼接
print("join拼接",".".join({"111","222"}))



