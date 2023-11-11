-- 1
USE art_gallery;

SELECT artfile
FROM artwork
WHERE period = "Impressionism";

-- 2
SELECT artfile
FROM artwork aw
	JOIN artwork_has_keyword ahk
    ON aw.artwork_id = ahk.artwork_id
    JOIN keyword k
    ON ahk.keyword_id = k.keyword_id
WHERE keyword LIKE "%flower%";

-- 3
SELECT fname, lname, title
FROM artist
	LEFT JOIN artwork
    ON artist.artist_id = artwork.artist_id;
    
-- 4
USE magazine;

SELECT magazineName, subscriberLastName, subscriberFirstName
FROM magazine
	JOIN subscription
    ON magazine.magazineKey = subscription.magazineKey
    JOIN subscriber
    ON subscription.subscriberKey = subscriber.subscriberKey
ORDER BY magazineName;

SELECT magazineName
FROM magazine
	JOIN subscription
    ON magazine.magazineKey = subscription.magazineKey
    JOIN subscriber
    ON subscription.subscriberKey = subscriber.subscriberKey
WHERE subscriberLastName = "Sanders";

-- 6
USE employees;

SELECT dept_name
FROM departments;

SELECT first_name, last_name
FROM employees e
	JOIN dept_emp d
    ON e.emp_no = d.emp_no
    JOIN departments dep
    ON d.dept_no = dep.dept_no
WHERE dept_name = "Customer Service"
ORDER BY last_name
LIMIT 5;

-- 7
SELECT first_name, last_name,  dept_name, salary, s.from_date
FROM employees e
	JOIN dept_emp d
    ON e.emp_no = d.emp_no
    JOIN departments dep
    ON d.dept_no = dep.dept_no
    JOIN salaries s 
    ON e.emp_no = s.emp_no
WHERE first_name = "Berni" && last_name = "Genin"
ORDER BY from_date DESC
LIMIT 1;


