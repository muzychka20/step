QUnit.module('Тестирование математических функций', function() {
    QUnit.test('Тест функции add()', function(assert) {
        assert.equal(add(1, 1), 2, '1 + 1 = 2');
        assert.equal(add(2, -2), 0, '2 + (-2) = 0');
        assert.equal(add(2, 3), 5, '2 + 3 = 5');
        assert.equal(add(3, 3), 6, '3 + 3 = 6');
    });

    QUnit.test('Тест функции multiply()', function(assert) {
        assert.equal(multiply(2, 3), 6, '2 * 3 = 6');
        assert.equal(multiply(5, -1), -5, '5 * (-1) = -5');
        assert.equal(multiply(0, 5), 0, '0 * 5 = 0');
    });

    QUnit.test('Тест функции substract()', function(assert) {
        assert.equal(substract(2, 3), -1, '2 - 3 = -1');
        assert.equal(substract(10, 3), 7, '10 - 3 = 7');
        assert.equal(substract(5, 2), 3, '5 - 2 = 3');
    });

    QUnit.test('Тест функции division()', function(assert) {
        assert.equal(division(12, 3), 4, '12 / 3 = 4');
        assert.equal(division(12, 0), Infinity, '12 / 0 = Infinity');
    });

    // QUnit.test('Тест функции addS()', function(assert) {
    //     assert.equal(addSpecific(1, 1), 3, '1 + 1 = 3');
    // });
});
