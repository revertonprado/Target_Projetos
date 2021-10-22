#!/usr/bin/env python
# coding: utf-8

# In[15]:


sp = float(67.83643)
rj = float(36.67866)
mg = float(29.22988)
es = float(27.16548)
outros = float(19.84953)
total = float(sp + rj + mg + es + outros)

porcsp = ((sp/total)*100)
porcrj = ((rj/total)*100)
porcmg = ((mg/total)*100)
porces = ((es/total)*100)
porcoutros = ((outros/total)*100)

print('SP: {}'.format(round(porcsp)),'%')
print('RJ: {}'.format(round(porcrj)), '%')
print('MG: {}'.format(round(porcmg)),'%')
print('ES: {}'.format(round(porces)),'%')
print('OUTROS: {}'.format(round(porcoutros)),'%')


# In[ ]:




