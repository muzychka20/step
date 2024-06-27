QUnit.module('Test calculation of areas:', () => {
    QUnit.test('Test squareArea()', (assert) => {
        assert.equal(squareArea(2), 4, 'a = 2, square = 4')
    })

    QUnit.test('Test rectangeArea()', (assert) => {
        assert.equal(rectangeArea(2, 4), 8, 'a = 2, b = 4, square = 8')
    })

    QUnit.test('Test triangleArea()', (assert) => {
        assert.equal(triangleArea(3, 4, 5), 6, 'a = 3, b = 4, c = 5, square = 6')
    })
})