#!/usr/bin/env python
# coding: utf-8

# In[25]:


import json
import pandas as pd


dados = pd.read_json(r'ColoqueoDiretorioDoAquivoAqui.json') #colocar o endereço do arquivo .json#
dados['valor'] = dados['valor'].astype('float')

lista = dados['valor'].astype('float')

display(dados)

minimo = lista[1]
indice = 0
contador = 0
for num in lista:
    if num < minimo and num != 0:
        minimo = num
        indice = contador + 1
    contador += 1

print ("Menor Valor: ", minimo, "Dia: " ,indice)



minimo2 = lista[1]
indice2 = 0
contador2 = 0
for num2 in lista:
    if num2 > minimo2 and num2 != 0:
        minimo2 = num2
        indice2 = contador2 + 1
    contador2 += 1

print ("Maior Valor: ", minimo2, "Dia: ", indice2)




media0 = (dados['valor'].loc[dados['valor'] != 0]).median()



r = (lista > media0)




dias = sum(r)

print('O número de dias que o faturamento foi maior de que média:', dias )


# In[ ]:




