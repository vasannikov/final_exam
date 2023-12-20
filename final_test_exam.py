import pandas as pd

# Создадим DataFrame
import random
lst = ['robot'] * 10
lst += ['human'] * 10
random.shuffle(lst)
data = pd.DataFrame({'whoAmI': lst})

# Получим уникальные значения в столбце "whoAmI"
unique_values = data['whoAmI'].unique()

# Для каждого уникального значения создадим новый столбец
for value in unique_values:
    data[value] = (data['whoAmI'] == value).astype(int)

# Удалим исходный столбец "whoAmI"
data.drop('whoAmI', axis=1, inplace=True)

print(data.head())

