USE bike;

-- 1
SELECT ROUND(COUNT(quantity))
FROM stock;

-- 2
SELECT DISTINCT product_name
FROM product p 
	JOIN stock st 
		ON p.product_id = st.product_id
WHERE quantity = 0
ORDER BY product_name;

-- 3 
USE bike;
SELECT category_name, COUNT(p.product_id) AS instock
FROM category c
	JOIN product p
		ON c.category_id = p.category_id
	JOIN stock s
		ON p.product_id = s.product_id
WHERE s.store_id = 2
GROUP BY category_name
ORDER BY COUNT(p.product_id);

-- 4
USE employees;

SELECT COUNT(emp_no) AS "Number of Employees" FROM employees;

-- 5
SELECT dept_name, FORMAT(AVG(salary), 2, 'en_US') AS average_salary
FROM departments d
	JOIN dept_emp de
		ON d.dept_no = de.dept_no
	JOIN salaries s 
		ON de.emp_no = s.emp_no
GROUP BY dept_name
HAVING AVG(salary) < 60000;

-- 6
SELECT dept_name, COUNT(gender) AS 'Number of Females'
FROM employees e
	JOIN dept_emp de
		ON e.emp_no = de.emp_no
	JOIN departments d
		ON de.dept_no = d.dept_no
WHERE gender = 'F'
GROUP BY dept_name;