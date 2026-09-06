-- Write your query below
select date_id,make_name, Count(distinct lead_id) as Unique_leads,Count(distinct partner_id) as unique_partners
from daily_sales
group by (date_id,make_name)
