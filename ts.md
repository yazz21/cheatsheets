```ts
// # intersection type
    type poo = quick & slow  

// # union type
    type foo = quick | slow

// # custome type check
    const canfly = (animal: animal): animal as fly 
        =>  typeof (animal as any).fly === 'function'

    if (canfly(animal)) {
        animal.fly()
    }