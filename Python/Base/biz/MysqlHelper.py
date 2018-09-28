import pymysql


class MysqlHelper:

    # 初始化方法
    def __init__(self, host, port, db, user, password, charset):
        self.host = host
        self.port = port
        self.db = db
        self.user = user
        self.password = password
        self.charset = charset

    # 创建连接
    def open_connection(self):
        self.conn = pymysql.connect(host=self.host, port=self.port, db=self.db, user=self.user, password=self.password,
                                    charset=self.charset)

        self.cursor = self.conn.cursor()

    # insert update delete
    def execute(self,sql,params=None):
        result = self.cursor.execute(sql,params)
        # 判断result，受影响的行数是否是大于1的
        if result > 0:
            print('操作成功！')
            self.conn.commit()  # 提交
        else:
            print('操作失败！')

    def close(self):
        self.cursor.close()
        self.conn.close()

    # 查询一条记录的封装
    def get_one(self,sql,params):
       result = self.cursor.execute(sql,params)
       if result>0:
           # 找到了匹配的记录
            data = self.cursor.fetchone()
            print(data)
            return 1
       else:
           # 没有任何数据
            print("没有符合条件的数据")
            return 0

    # 查询多条数据
    def get_all(self,sql,params=None):
        result = self.cursor.execute(sql, params)
        if result > 0:
            # 找到了匹配的记录
            data = self.cursor.fetchall()
            # 遍歷元組
            for d in data:
                print(d)
        else:
            # 没有任何数据
            print("没有符合条件的数据")

 