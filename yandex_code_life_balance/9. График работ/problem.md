# 9. График работ

Пете на работе выдали n задач.

Каждый день, начиная с первого, Петя может выполнить ровно одну задачу. Про каждую задачу известен последний день di, когда её можно выполнить, и величина стресса wi, который Петя испытает, если задача не будет выполнена в срок и надо будет просить помощи коллег.

Помогите Пете решить, в каком порядке выполнять задачи, чтобы уменьшить его суммарный стресс.

## Формат ввода

В первой строке дано единственное натуральное число n (1≤n≤200 000) — количество задач.

Затем следует n строк, в каждой из которых содержится по два числа di и wi (1≤di≤200 000, 1≤wi≤200 000) — последний день, когда можно выполнить задачу, и стресс при пропуске дедлайна для i-й задачи.

## Формат вывода

Выведите единственное число, равное минимальному возможному суммарному стрессу.


<table>
 <tr>
    <td>Ограничение времени</td>
    <td>1 с</td>
 </tr>
 <tr>
    <td>Ограничение памяти</td>
    <td>256.0Mb</td>
 </tr>
</table>

### Пример 1

Ввод

   3
   1 2
   1 3
   3 1

Вывод

   2
