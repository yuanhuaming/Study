#string的修改，会复制一个新的地址，和list的区别


# ASCII 码转换
print("ASCII 码转换",ord('a') ,chr(97))

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

#字符串占位符替换
print("字符串占位符", "I love %s" % "python")
print("字符串占位符", "I love {} , love {} too".format("python",".net"))

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


