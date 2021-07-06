SELECT 
Case 
WHEN A+B <= C THEN 'Not A Triangle'
WHEN A = B AND A = C THEN 'Equilateral'
WHEN A = B OR A = C OR B = C THEN 'Isosceles' 
ELSE 'Scalene' 
END 
FROM TRIANGLES

------------------------------------------------

SELECT NAME + '(' +LEFT(OCCUPATION, 1) + ')' FROM OCCUPATIONS ORDER BY NAME;
SELECT 'There are a total of ' + cast(count(occupation) AS char) + LOWER(occupation) + 's.'
FROM OCCUPATIONS GROUP BY OCCUPATION ORDER BY count(occupation);

------------------------------------------------

SELECT c.company_code, c.founder, 
COUNT(DISTINCT l.lead_manager_code),
COUNT(DISTINCT s.senior_manager_code),
COUNT(DISTINCT m.manager_code),
COUNT(DISTINCT employee_code)
FROM company c, lead_manager l, senior_manager s, manager m, employee e
WHERE
c.company_code=l.company_code and
l.lead_manager_code=s.lead_manager_code and
s.senior_manager_code=m.senior_manager_code and
m.manager_code=e.manager_code
GROUP BY c.company_code, c.founder 
ORDER BY c.company_code

---

SELECT company.company_code, company.founder, 
(SELECT COUNT(DISTINCT(lead_manager.lead_manager_code)) FROM lead_manager WHERE lead_manager.company_code = company.company_code), 
(SELECT COUNT(DISTINCT(Senior_Manager.senior_manager_code)) FROM Senior_Manager WHERE Senior_Manager.company_code = company.company_code), 
(SELECT COUNT(DISTINCT(Manager.manager_code)) FROM Manager WHERE Manager.company_code = company.company_code), 
(SELECT COUNT(DISTINCT(Employee.Employee_Code)) FROM Employee WHERE Employee.company_code = company.company_code)  
FROM company 
ORDER BY company.company_code; 


SELECT company.company_code, company.founder FROM company cm

SELECT Cast(SUM(LAT_N) as decimal(18,4)) FROM STATION WHERE LAT_N BETWEEN 38.7889 AND 137.2345
--- = ---
SELECT CONVERT(NUMERIC(18,4),SUM(LAT_N)) FROM STATION WHERE LAT_N BETWEEN 38.7889 AND 137.2345

SELECT Cast(MAX(LAT_N) as decimal(18,4)) FROM STATION WHERE LAT_N < 137.2345


SELECT TOP 1 CAST(LONG_W as decimal(16,4)) FROM STATION WHERE LAT_N < 137.2345 ORDER BY LAT_N DESC
--- = ---
SELECT CAST(LONG_W AS DECIMAL(16,4)) FROM STATION WHERE LAT_N = (SELECT MAX(LAT_N) FROM STATION WHERE LAT_N < 137.2345)



SELECT TOP(1) CAST(LONG_W as decimal(16,4)) FROM STATION 
GROUP BY LONG_W, LAT_N 
HAVING MIN(LAT_N) > 38.7889 
--- = ---
SELECT TOP(1) CAST((LONG_W)AS NUMERIC(10,4)) FROM STATION 
GROUP BY LONG_W, LAT_N 
HAVING LAT_N>38.7780 
ORDER BY LAT_N ASC;


SELECT CAST((ABS(MIN(LAT_N) - MAX(LAT_N)) + ABS(MIN(LONG_W) - MAX(LONG_W))) as decimal(16,4)) FROM STATION

SELECT CAST(SQRT(
        POWER(MAX(LAT_N)  - MIN(LAT_N),  2)
      + POWER(MAX(LONG_W) - MIN(LONG_W), 2)
    ) as decimal(16,4)) FROM STATION



------------------------------------------------

SELECT SUM(POPULATION) FROM CITY WHERE COUNTRYCODE='JPN' GROUP BY COUNTRYCODE
SELECT MAX(POPULATION) - MIN(POPULATION) FROM CITY

SELECT CAST(
        CEILING(AVG(CAST(salary as float )) - AVG(CAST (REPLACE(salary ,0,'') as float ))) as int
           ) FROM Employees

SELECT Max(salary*months), Count(Name) from Employee where salary*months=(SELECT Max(salary*months) from Employee);

SELECT cast(ROUND(SUM(LAT_N),2) as decimal(16,2)) ,cast( ROUND(SUM(LONG_W),2) as decimal(16,2)) FROM STATION;

------------------------------------------------

-- PERCENTILE_DISC: Computes a specific percentile for sorted values in an entire rowset or within a rowset's distinct partitions in SQL Server. 
-- For a given percentile value P, PERCENTILE_DISC sorts the expression values in the ORDER BY clause.
-- It then returns the value with the smallest CUME_DIST value given (with respect to the same sort specification) 
-- that is greater than or equal to P. For example, PERCENTILE_DISC (0.5) will compute the 50th percentile (that is, the median)
-- of an expression 
select distinct cast(
        PERCENTILE_DISC (.5) WITHIN GROUP (order by lat_n) OVER() 
        as decimal(10,4)
    )
from station

------------------------------------------------

with c1 as (
    select hacker_id, count(*) as c_COUNT
    from Challenges as c
    group by hacker_id
), c2 as (
    select max(c_COUNT) as max_c_COUNT 
    from c1
), c3 as (
    select c_COUNT
    from c1
    where c_COUNT < (select top 1 max_c_COUNT from c2)
    group by c_COUNT
    having count(*) = 1
    
    union 
    select max_c_COUNT from c2
)
select h.hacker_id, h.name, c1.c_COUNT
from c1 
join c3 on c1.c_COUNT = c3.c_COUNT
join Hackers as h on c1.hacker_id = h.hacker_id 
order by c1.c_COUNT desc, hacker_id

------------------------------------------------

