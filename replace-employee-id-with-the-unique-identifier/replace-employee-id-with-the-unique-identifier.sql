/* Write your T-SQL query statement below */
select eu.unique_id, e.name from Employees e
LEFT JOIN EmployeeUNI eu ON e.id = eu.id;