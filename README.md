# GenerateCode
基于SqlSugar 提供的数据底层连接能力实现实体、业务等生成
使用该程序你需要对Velocity的语法有一定的了解
目前仅提供了MySql的连接驱动
基本的实体生成已经可以使用(使用方法：添加连接-选择模版分组-选择保存路径-选择需要生成的表或者库-生成)
![image](https://user-images.githubusercontent.com/27138744/122718580-b13b0400-d29f-11eb-952b-79b9f28edd2f.png)
目前 $tools 有如下方法
![image](https://user-images.githubusercontent.com/27138744/122718818-f4957280-d29f-11eb-9b59-00ede40a1033.png)
$dbTool 有如下方法
![image](https://user-images.githubusercontent.com/27138744/122718966-24dd1100-d2a0-11eb-9da9-03733c3a1ba0.png)
此处详情请参考: https://www.donet5.com/Home/Doc?typeId=1203

${namespace} 填写的名命空间
${tableName} 表名(原生)
${tableColumns} 表中的所有列
${tableInfo} 表的详细信息
templateh目录下有一个参考模版
Velocity语法详情可参考官网：http://velocity.apache.org/engine/devel/user-guide.html
预览生成:单击对应的模版文件进行预览
