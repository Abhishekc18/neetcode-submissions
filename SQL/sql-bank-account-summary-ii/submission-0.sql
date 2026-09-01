-- Write your query below
select u.name, Sum(t.amount) as balance
from users u
Join transactions t On u.account = t.account
group by u.name
having Sum(t.amount) > 10000