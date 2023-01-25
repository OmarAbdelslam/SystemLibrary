use Libarary
Create table Book
(
B_ID int primary key ,
B_Address nvarchar(20) not null ,
B_Num_National varchar(10) not null ,
B_Input_Libarary datetime ,
B_As2ra varchar(8) ,
B_Buy   varchar(8) ,
B_Salary numeric(10,00),
B_Num_Copy int ,
B_Location_Liba varchar(10) ,
B_Num_Location_Liba varchar(10) ,
B_Num_Chapter int ,
B_Type_Printer varchar(20) ,
B_Date_Printer datetime 
)


create table Book_Authores
(
B_A_NUM int ,
Parametar_A_ID int ,
Parametar_B_ID int  
)

alter table Book_Authores
add  foreign key (Parametar_B_ID ) references Book (B_ID)
 select * from Book_Authores
 