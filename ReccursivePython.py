def fun(n, res=1):
    if n <= 0:
        return res
    return fun(n - 1, n * res)

print(fun(5))



# def fun(n, res=1):
#  (5,1)
#  (4,20)
#  (3,60)
#  (2,120)
#  (1,120)
#     if n <= 0: 
#         return res 
#     return fun(n - 1, n * res) 


# print(fun(5))
