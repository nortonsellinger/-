USE lib3
SELECT TOP 5 EmployeeID, COUNT(*) AS Count
FROM BOOKLEND
GROUP BY EmployeeID
ORDER BY Count DESC
