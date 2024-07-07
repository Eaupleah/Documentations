use Northwind
select * from dbo.[Order Details]
select * from Products
select * from Employees
select * from Orders

-- Çalışanların yapmış olduğu sipariş adedi (orders)  

SELECT EmployeeID, COUNT(*) AS [Toplam Satis Adedi]
FROM Orders
GROUP BY EmployeeID

-- Employees tablosundan; FirstName alanına göre, isimleri ASC olarak sıraladıktan sonra, sonuç kümesinin ilk beş kaydını ülkelerine göre gruplayınız.

SELECT Country, COUNT(*) AS [Toplam Personel Sayısı]
FROM
(
    SELECT TOP 5 FirstName, Country
    FROM Employees	
    ORDER BY FirstName
) AS Personeller -- derived table
GROUP BY Country

-- Ürün bedeli 35$'dan az olan ürünlerin kategorilerine göre gruplanması

select CategoryID, count(*) as 'Toplam Urun Adedi'
from
(
    select ProductID, CategoryID
    from Products
    where UnitPrice < 35
) as Urunler
group by categoryID

-- Baş harfi A-K aralığında olan ve stok miktarı 5 ile 50 arasında olan ürünleri kategorilerine göre gruplayınız.

select CategoryID, count(*) as 'Toplam Urun Adedi'
from
(
    select CategoryID, ProductName, UnitsInStock
    from Products
    where UnitsInStock between 5 and 50
          and
		  ProductName like '[A-K]%'
) as Urunler
group by CategoryID

-- Her bir siparişteki toplam ürün sayısını bulunuz.

select OrderID, sum(Quantity) as 'Toplam Urun Sayisi'
from dbo.[Order Details]
group by OrderID

-- Her bir siparişin tutarına göre listelenmesi

select OrderID, sum(Quantity * UnitPrice) as 'Toplam Fiyat'
from dbo.[Order Details]
group by OrderID

-- Toplam tutarı 2500 ile 3500 arasında olan siparişlerin gruplanması

select OrderID, sum(Quantity * UnitPrice) as 'Toplam Fiyat'
from dbo.[Order Details]
group by OrderID
having sum(Quantity * UnitPrice) between 2500 and 3500

-- Her bir siparişteki toplam ürün sayısı 200'den az olanlar

select OrderID, sum(Quantity) as 'Toplam Urun Sayisi'
from dbo.[Order Details]
group by OrderID
having sum(Quantity) < 200
