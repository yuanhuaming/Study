

#成绩统计
# 问题描述：已知10个面试成绩，请对其进行统计，输出优
#（100～90）、良（89～80）、中（79～60）、差（59～0）4个等级的人数

def tongji1():    
    score = [68, 75, 32, 99, 78, 45, 88, 72, 83, 78]

    a = 0;    b = 0;    c = 0;    d = 0

    #输出所有成绩
    print ("成绩分别为： ")
    for s in score :
        print (s)

    #换行
    print

    #对成绩进行分段统计
    for s in score :
        if s < 60 :
            d = d + 1
        elif s < 80 :
            c = c + 1
        elif s < 90 :
            b = b + 1
        else :
            a = a + 1

    print ("分段统计结果： 优", a, "人， 良", b, "人， 中", c, "人，差", d, "人")


#成绩排序问题（使用字典）
#问题描述：已知10名面试人员的姓名和成绩，请找出其中的最高分和最低分，并找出全部面试人员的平均分
def tongji2():
    studscore = {"唐僧":45, "孙悟空":78, "猪八戒":40, "沙僧":96, "如来":65, "观音":90,
             "白骨精":50, "红孩儿":99, "太上老君":80, "白龙马":87}

    min,max=100,0
    minname,maxname='',''
    avg=0;
    for key in  studscore.keys():
        if studscore[key]>max:
            max= studscore[key]
            maxname =key;
        if studscore[key]< min:
            min=studscore[key]
            minname = key;
        avg+=studscore[key];
    print(maxname ,max)
    print(minname,min)
    print(avg/len(studscore))



tongji1()
tongji2()