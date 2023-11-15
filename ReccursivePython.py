def fun(n, res=1):
    if n <= 0:
        return res
    return fun(n - 1, n * res)

print(fun(5))
