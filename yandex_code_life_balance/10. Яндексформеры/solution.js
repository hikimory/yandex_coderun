// Классический Array.sort(compareNumeric) не подходит ломается на 45 тесте и того решено 45/88
// Другие сортировки так же
// Словарь спас ситуацию )))

/**
* @param {number} N - целое число, количество сотрудников готовых к объединению
* @param {number[]} staff - массив длины N с грейдами доступных сотрудников
* @param {number} K - целое число, количество доступных клавиатур
* @returns {number}
*/
module.exports = function (N, staff, K) {
    let result = 0;
    let obj = {};

    for (let i = 0; i < staff.length; i++) {
        const graid = staff[i];
        obj[graid] = (obj[graid] || 0) + 1;
    }

    objKeys = Object.keys(obj)
    for (let i = objKeys.length; i > 0; i--) {
        if (K >= obj[objKeys[i - 1]]) {
            result += objKeys[i - 1] * obj[objKeys[i - 1]];
            K -= obj[objKeys[i - 1]];
        } else {
            result += objKeys[i - 1] * K;
            break;
        }
    }
    return result;      
}
