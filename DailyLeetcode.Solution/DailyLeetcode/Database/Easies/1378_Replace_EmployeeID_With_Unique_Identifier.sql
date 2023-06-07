SELECT u.unique_id, e.NAME  
    FROM Employees AS e 
    LEFT JOIN EmployeeUNI AS u
    ON e.id = u.id;