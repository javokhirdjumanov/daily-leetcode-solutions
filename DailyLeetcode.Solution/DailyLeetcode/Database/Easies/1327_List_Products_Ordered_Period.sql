SELECT pro.product_name, SUM(ord.unit) AS unit
FROM Products AS pro 
RIGHT JOIN Orders AS ord ON ord.product_id = pro.product_id
WHERE ord.order_date BETWEEN '2020-02-01' AND '2020-02-29'
GROUP BY pro.product_name
HAVING SUM(ord.unit) > 99;