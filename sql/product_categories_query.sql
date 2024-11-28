SELECT 
    p.ProductName,
    c.CategoryName
FROM 
    Products p
    LEFT JOIN ProductCategories pc ON p.ProductId = pc.ProductId
    LEFT JOIN Categories c ON pc.CategoryId = c.CategoryId
ORDER BY 
    p.ProductName,
    c.CategoryName; 