-- Write your query below
select sale_date, 
Sum(case when s.fruit = 'apples' then sold_num else 0 end) - Sum(case when s.fruit = 'oranges' then sold_num else 0 end) as diff
from sales s
group by sale_date
order by sale_date