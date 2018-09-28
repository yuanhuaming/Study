import pymysql
import datetime
from dateutil.relativedelta import relativedelta
from decimal import getcontext, Decimal

        # 打开数据库连接
db = pymysql.connect("192.168.0.7","root","mdd888admin","dms_erp" )
 
# 使用 cursor() 方法创建一个游标对象 cursor
cursor = db.cursor()
 
# 使用 execute()  方法执行 SQL 查询 
cursor.execute("SELECT  a.id, c.`contract_date`,  c.`actual_months`, c.`contract_money`/1.06 as contract_money, c.`contract_money` / c.actual_months/1.06 AS permoney    FROM db_project a LEFT JOIN db_project_bg b ON a.id=b.`pid` \
RIGHT JOIN db_project_funds c ON a.`id`= c.`pid`\
WHERE  a.`project_num` LIKE '%yx%' order by a.id")
 
# 使用 fetchone() 方法获取单条数据.
datas = cursor.fetchall()
 
for row in datas:
      pid = row[0]
      contract_date = row[1]
      actual_months = row[2]
      contract_money = Decimal(row[3]).quantize(Decimal('0.00'))
      permoney = Decimal(row[4]).quantize(Decimal('0.00'))
      # 打印结果
      print ("pid=%s,contract_date=%s,actual_months=%s,contract_money=%s,permoney=%d" % \
             (pid, contract_date, actual_months, contract_money, permoney ))
      tempAmount = 0
      for num in range(0,actual_months,1):
      
          year = (contract_date +relativedelta(months=+num)).year
 
          month= (contract_date +relativedelta(months=+num)).month
   
          if num==actual_months-1:
            money = contract_money -tempAmount
          else:
            money =permoney 

          tempAmount+=permoney
    
          sql="insert into `db_project_income` (`project_id`,`year`,`month`,`money`,`update_uid`,`update_date`) values({},{},{},{},{},'{}')".format(pid,year,month,money,1,datetime.datetime.now())  
          cursor.execute(sql)
          db.commit() 

# 关闭数据库连接
db.close()
 