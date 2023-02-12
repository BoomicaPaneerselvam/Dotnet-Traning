--query 1
select FirstName,LastName,Title  from Person.Person where  title is not null
--query 2
select FirstName,LastName from Person.Person where FirstName like'%a%' and LastName  like'%a%'
--query 3
select*from Sales.CountryRegionCurrency
select*from sales.Currency
select name,CurrencyCode from sales.Currency
where CurrencyCode in(select CurrencyCode from Sales.CountryRegionCurrency)

---query 4
select*into HR_Dept
from HumanResources.Department
select*from HR_Dept

----query 5
select*from personalinfo
create table personalinfo
(sno int identity(1,1),
Name varchar(25),
Gender char(1),
City varchar(10),
State varchar(10))

declare @con int
set @con=1
while @con<=20
begin
insert into personalinfo
values('Boomica','f','vellore','Tamil Nadu')
set @con=@con+1
end


---query6
select*from HumanResources.Department
select*from Person.BusinessEntityAddress

select BusinessEntityID,AddressTypeID
from Person.BusinessEntityAddress ba
join HumanResources.Department dept
on dept.DepartmentID=ba.BusinessEntityID

---query7

select distinct  GroupName  from HumanResources.Department

---query 8

select*from Production.ProductCostHistory
select*from Production.Product
select sum(listprice) listprice,StandardCost from Production.Product
group by StandardCost

--query 9

select*from HumanResources.EmployeeDepartmentHistory
SELECT DATEDIFF(year,StartDate,EndDate ) AS DateDiff from HumanResources.EmployeeDepartmentHistory

--query 10

select*from Sales.SalesPersonQuotaHistory
UPDATE
    sales.SalesPersonQuotaHistory
SET
   Salesquota = SalesQuota + 5000;
   select *from sales.SalesPersonQuotaHistory
   where SalesQuota>=100000
   order by 1 asc

---query11
select max(taxrate) Max_taxrate from Sales.SalesTaxRate

---query12
 select*from HumanResources.Employee--business id,birthdate
 select*from HumanResources.Department--dept id
 select*from HumanResources.EmployeeDepartmentHistory--shift id


select emp.BusinessEntityID,BirthDate, dept.DepartmentID,
getdate() as CurrentDate, year(getdate())-year(birthDate) as age
from HumanResources.Employee emp
join HumanResources.EmployeeDepartmentHistory empdhis
on emp.BusinessEntityID=empdhis.BusinessEntityID
join HumanResources.Department dept
on dept.DepartmentID= empdhis.DepartmentID
order by BusinessEntityID asc

--query 13
create view	VW_Name_age
as
select emp.BusinessEntityID,BirthDate, dept.DepartmentID,
getdate() as CurrentDate, year(getdate())-year(birthDate) as age
from HumanResources.Employee emp
join HumanResources.EmployeeDepartmentHistory empdhis
on emp.BusinessEntityID=empdhis.BusinessEntityID
join HumanResources.Department dept
on dept.DepartmentID= empdhis.DepartmentID

select*from VW_Name_age


---query15
select*from HumanResources.Department
select*from HumanResources.EmployeeDepartmentHistory
select dept.DepartmentID,name,GroupName,max(Rate) Max_rate from HumanResources.Department dept
join HumanResources.EmployeeDepartmentHistory dhis
on dept.DepartmentID=dhis.DepartmentID
join HumanResources.EmployeePayHistory dpayhis
on dept.DepartmentID=dpayhis.BusinessEntityID
group by dept.DepartmentID,GroupName,Name
select*from HumanResources.EmployeePayHistory
where DepartmentID=1

---query16
select*from Person.Person -->first,last,middle,title(not null)
select*from Person.BusinessEntityAddress

select per.BusinessEntityID,FirstName,LastName,MiddleName,addresstypeid,Title
from Person.Person per
left join Person.BusinessEntityAddress pa
on per.BusinessEntityID=pa.BusinessEntityID
where title is not null
order by per.BusinessEntityID 

--query 17
 

 select ProductID,LocationID,Shelf from Production.ProductInventory
 where ProductID between 300 and 350
 and LocationID=50
 or shelf='E'

 --query 18

select*from Production.ProductInventory
select*from Production.Location

select pl.LocationID,Shelf,Name
from Production.ProductInventory pin
join Production.Location pl
on pl.LocationID=pin.LocationID
order by LocationID

--query  19
 select*from Person.StateProvince 
 select*from Person.Address

 select addressline1,AddressLine2,sp.StateProvinceID,StateProvinceCode,CountryRegionCode
 from Person.StateProvince sp
 join Person.Address addr
 on sp.StateProvinceID=addr.StateProvinceID

 --query 20
 select*from Sales.SalesOrderHeader --subtotal,taxamnt
  select*from Sales.SalesTerritory 
  select*from Sales.CountryRegionCurrency--currency code

  select sum(subtotal) sum,TaxAmt Total,CurrencyCode
  from sales.SalesOrderHeader sh
  join sales.SalesTerritory st
  on sh.TerritoryID=st.TerritoryID
  join sales.CountryRegionCurrency cc
  on st.CountryRegionCode=cc.CountryRegionCode
  group by TaxAmt,CurrencyCo


