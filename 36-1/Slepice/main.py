with open("05.in", "r") as soubor:
    k, p, d = map(int, soubor.readline().split())

dny=[0] * 500000
dny[k]=1

for i in range(0, d + 1):
    if dny[i] > 0:
        j=i+k+p
        while j<=d:
            dny[j]+=dny[i]
            j+=p

print(sum(dny))