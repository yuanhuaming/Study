
#for 
def useFor():
    for i in range(1, 10, 1):
        for j in range(1, i+1, 1):
            print (i, '*', j, '=', i*j, '\t',)
        print ('\n')


#foreach
def useForeach():
    print ("方法1：使用Python的内建函数max()/min()求最高分/最低分")
    score = [70, 90, 78, 85, 97]

    print ('最高分：', max(score))
    print ('最低分：', min(score))

    print ("方法2：用for循环求最高分/最低分")
    max_score = score[0]
    min_score = score[0]
    print ('所有的分数是：')
    for i in score:
        print (i), 
        if i > max_score:
            max_score = i
        if i < min_score:
            min_score = i
    print ('\n')
    print ('最高分 = ', max_score)
    print ('最低分 = ', min_score)

#while
def useWhile():
    endflag="yes"
    sum=0.0
    count=0

    while endflag[0]=='y':
        x = input("请输入一个分数")
        sum = sum + int(x)
        count = count + 1
        endflag = input("继续输入吗？(yes or no)?")

    print ("\n平均分是： ", sum/count)

def useWhile2():
    print ('请输入若干字符，当输入字符#时结束该操作')

    while True:
        a =  input('请输入一个字符： ')
        if a != '#':
            print ('您输入的字符是： ', a)
        else:
            break 



useWhile()