--Исходим из того, что у нас есть две таблицы Products и Categories со столбцами ID и Name
--Также есть таблица сопоставлений продуктов и категорий ProductCategoryRelations со столбцами ProductID и CategoryID
SELECT Products.Name, Categories.Name
FROM Products
LEFT JOIN ProductCategoryRelations Rel
	ON Products.ID = Rel.ProductID
LEFT JOIN Categories
	ON Rel.CategoryID = Categories.ID;