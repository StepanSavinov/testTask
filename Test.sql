SELECT p.Name as Product_Name, c.Name as Category_Name
FROM dbo.Product p
LEFT JOIN dbo.ProductCategory pc
ON p.Id = pc.ProductId
LEFT JOIN dbo.Categories c
ON c.Id = pc.CategoryId