
root = Tk()# 窗口大小 窗口位置

root.geometry('600x300+500+300')

# 标签控件 可以设置字体 大小 颜色

label = Label(root, text='签名', font=('华文行楷', 20),fg = 'red')# 定位

label.grid()