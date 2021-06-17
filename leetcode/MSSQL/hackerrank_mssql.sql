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

