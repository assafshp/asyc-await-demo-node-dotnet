require('log-timestamp');

(async function main(){
    console.log('main function started');
    await sleep();
    console.log('main function ended');
})();

async function timeout(ms) {
    return new Promise(resolve => setTimeout(()=> {
        console.log('timeout ended');
        resolve(true);
    }, ms));
}
async function sleep() {
    return timeout(3000);
}

