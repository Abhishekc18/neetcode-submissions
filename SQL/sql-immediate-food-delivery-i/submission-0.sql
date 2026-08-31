select Round(Sum(Case when order_date = customer_pref_delivery_date then 1.0 else 0.0 end) / count(*) * 100, 2)
as immediate_percentage
from delivery