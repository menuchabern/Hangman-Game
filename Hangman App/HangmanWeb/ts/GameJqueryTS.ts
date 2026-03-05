
const words = ["AN", "TO", "UP", "CAT", "SUN", "PEN", "TREE", "BOOK", "FISH", "APPLE", "CHAIR", "WATER",
    "PLANET", "ORANGE", "SILVER", "TEACHER", "AIRPORT", "PICTURE", "COMPUTER", "ELEPHANT", "BUILDING", "DICTIONARY", "CHOCOLATE", "BACKPACK"];

let amntofletters;
console.log(amntofletters);
let chosenword: string;
let triesleft = 13;

let letters: Element[];
let allboxes: Element[];
let txttriesleft: Element;
let msg: Element;
let img: HTMLImageElement;
let gameboxes: Element[] = [];

$(document).ready(function () {
    letters = [...document.querySelectorAll(".l")];
    allboxes = [...document.querySelectorAll(".b")];
    txttriesleft = document.querySelector("#triesleft");
    msg = document.querySelector("#msg");
    img = document.querySelector("#hangmanImg");
    //$(letters).click(guessLetter).prop("disabled", true);
    letters.forEach(l => {
        l.addEventListener("click", guessLetter);
        (l as HTMLInputElement).disabled = true;
    })
    $("#start").click(startGame);
});

function startGame() {
    msg.textContent = "";
    msg.classList.remove("text-success");
    msg.classList.remove("text-danger");
    $(allboxes).prop("value", "");
    img.src = `/images/p13p.png`;
    amntofletters = Number((document.querySelector("#anmtletters") as HTMLInputElement).value);
    console.log(amntofletters);
    txttriesleft.textContent = "12 tries left";
    triesleft = 13;
    $(letters).prop("disabled", true);

    if (amntofletters && amntofletters < 10 && amntofletters > 1) {
        gameboxes = allboxes.slice(0, amntofletters);
        $(allboxes).addClass("border-white");
        $(gameboxes).removeClass("border-white").addClass("border-primary");
        chosenword = getRandomWordByLength(amntofletters);
        console.log(chosenword);
        $(letters).prop("disabled", false);
    }
    else {
        $(msg).addClass("text-black").text("Please choose a valid number from 2 - 9.");
    }
}

function guessLetter(event: Event) {
    let letter = (event.target as HTMLInputElement).textContent;
    (event.target as HTMLInputElement).disabled = true;
    console.log(letter);
    if (chosenword.includes(letter)) {
        const positions = [...chosenword].map((c, i) => c === letter ? i : -1).filter(i => i !== -1);
        positions.forEach(i => (gameboxes[i] as HTMLInputElement).value = letter);
    }
    else {
        triesleft = triesleft - 1;
        img.src = `/images/p${triesleft}p.png`;
        txttriesleft.textContent = triesleft - 1 + " tries left";
    }

    checkForWin();
    checkForLose();
}

function checkForWin() {
    if (gameboxes.every(b => (b as HTMLInputElement).value)) {
        msg.textContent = "You Won!!";
        $(letters).prop("disabled", true);
        $(msg).removeClass("text-black").addClass("text-success");
    }
}

function checkForLose() {
    if (triesleft < 2) {
        msg.textContent = "You Lost! The word was " + chosenword;
        letters.forEach(b => (b as HTMLInputElement).disabled = true);
        $(msg).removeClass("text-black").addClass("text-danger");
    }
}

function getRandomWordByLength(length: number) {
    const filtered = words.filter(w => w.length === length);
    return filtered[Math.floor(Math.random() * filtered.length)];
}