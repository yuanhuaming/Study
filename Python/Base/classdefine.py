#coding=utf-8

class Fruit:
    price = 0
    def __init__(self):
        self.__color = 'Red'
        self.__city = 'KunMing'

    def __outputColor(self):         #定义私有方法
        print (self.__color)         #访问私有属性__color

    def __outputCity(self):
        print (self.__city)

    def output(self):
        self.__outputCity()
        self.__outputColor()

    @ staticmethod
    def getPrice():
        return Fruit.price

    @ staticmethod
    def setPrice(p):
        Fruit.price = p

if __name__ == "__main__":
    apple = Fruit()
    apple.output()
    print (Fruit.getPrice())
    Fruit.setPrice(9)
    print (Fruit.getPrice())







#coding=utf-8

#class Car:
#    price = 200000 #定义类属性(静态变量)
#    def __init__(self, c):
#        self.color = c   #定义实例属性

#if __name__ == "__main__":
#    car1 = Car("Red")
#    car2 = Car("Blue")

#    print (car1.color, Car.price)
#    Car.price = 150000  #修改类属性
#    Car.name = 'minicooper'  #增加类属性

#    car1.color = 'Yellow' #修改实例属性
#    print (car2.color, Car.price, Car.name)
#    print (car1.color, Car.price, Car.name)




#coding=utf-8

#class Fruit:
#    def __init__(self):
#        self.__color = 'Red'  #__开头则是私有属性
#        self.price = 2

#if __name__ == "__main__":
#    apple = Fruit()
#    apple.price = 3

#     #Python提供了访问私有属性的方式，可用于程序的测试和调试
#     #对象名._类名+私有成员名
#    print (apple.price, apple._Fruit__color)

#    apple._Fruit__color = 'Blue'
#    print (apple.price, apple._Fruit__color)

#    print (apple.__color)
#    peach = Fruit()
#    print (peach.price, peach._Fruit__color)

