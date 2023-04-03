// * Estilo

const root = document.documentElement;
const bgcolor1 = window.getComputedStyle(root).getPropertyValue('--bgcolor-1');
const bgcolor2 = window.getComputedStyle(root).getPropertyValue('--bgcolor-2');
const bgcolor3 = window.getComputedStyle(root).getPropertyValue('--bgcolor-3');
const bgcolor4 = window.getComputedStyle(root).getPropertyValue('--bgcolor-4');

// * Preguntas

// - ¿Cómo se modifica un elemento del DOM?
const divModificarElemento = document.getElementById("div-modificar-elemento");
const colorDivModificarElemento = divModificarElemento.style.color;
const btnModificarElemento = document.getElementById("btn-modificar-elemento");

btnModificarElemento.addEventListener("click", () =>
    divModificarElemento.style.color == colorDivModificarElemento ? divModificarElemento.style.color = bgcolor1 : divModificarElemento.style.color = colorDivModificarElemento
);

// - ¿Qué es un evento?
const btnEvento = document.querySelector("#btn-evento");
btnEvento.addEventListener("click", () => alert("Este es un evento: se hizo click en el botón"));

// - ¿Qué es un objeto de evento?
const miElemento = document.getElementById('btn-cambiar-fondo');
const bgcolorMiElemento = miElemento.style.backgroundColor;

miElemento.addEventListener('click', (evento) =>
    evento.target.style.backgroundColor == bgcolorMiElemento ? evento.target.style.backgroundColor = bgcolor1 : evento.target.style.backgroundColor = bgcolorMiElemento
);

// * Ejercicios de código

// - Posición del mause
const mousePosition = document.getElementById("mousePosition");
document.addEventListener('mousemove', function (event) {
    const x = event.clientX;
    const y = event.clientY;
    mousePosition.textContent = `Posición del mouse: (${x}, ${y})`;
});

// - Obtener nombre completo desde cajas de texto
const myForm = document.getElementById('form1');
const resultadoP = document.getElementById('resultadoEjercicio2');

myForm.addEventListener('submit', function (event) {
    event.preventDefault();
    const formData = new FormData(myForm);
    const nombre = formData.get('fname') == null ? "" : formData.get('fname');
    const apellido = formData.get('lname') == null ? "" : formData.get('lname');
    const nombreCompleto = `${nombre} ${apellido}`;
    resultadoP.innerHTML = nombreCompleto;
});

// - Agregar columnas o filas a una tabla
const btnInsertR = document.getElementById('btn-insert-r');

btnInsertR.addEventListener("click", function addRow() {
    const table = document.getElementById('sampleTable');
    const rows = table.rows;
    const cells = table.rows[0].cells.length;
    const newRow = table.insertRow(-1);

    for (let i = 0; i < cells; i++) {
        const newCell = newRow.insertCell(i);
        newCell.innerHTML = `Row ${rows.length} column ${i + 1}`;
    }
});

const btnInsertC = document.getElementById('btn-insert-c');

btnInsertC.addEventListener("click", function addColumn() {
    const table = document.getElementById('sampleTable');
    const rows = table.rows;
    const columns = table.rows[0].cells.length;
    for (let i = 0; i < rows.length; i++) {
        const newCell = rows[i].insertCell(-1);
        newCell.innerHTML = `Row ${i + 1} column ${columns + 1}`;
    }
});

// - Modificar celdas de una tabla
const btnChangeTable = document.getElementById("btn-change");

btnChangeTable.addEventListener("click", function updateTable() {
    const row = document.getElementById('rowIndex').value - 1;
    const column = document.getElementById('colIndex').value - 1;
    const text = document.getElementById('newValue').value;
    const table = document.getElementById('myTable');
    if (row >= table.rows.length || row < 0 || column >= table.rows[0].cells.length || column < 0) {
        alert('Invalid row or column number');
        return;
    }
    table.rows[row].cells[column].innerHTML = text;
});

// - Agregar y quitar elementos de una lista de opciones
document.getElementById("btn-add-color")
    .addEventListener("click", function addOption() {
        const colors = ['Red', 'Green', 'White', 'Black', 'Blue', 'Yellow', 'Orange', 'Purple', 'Brown']; // array of colors
        const randomColor = colors[Math.floor(Math.random() * colors.length)]; // pick a random color
        const select = document.getElementById('colorSelect');
        const option = document.createElement('option');
        option.value = randomColor;
        option.text = randomColor;
        select.add(option);
    });

document.getElementById("btn-rmv-color")
    .addEventListener("click", function removeOption() {
        const select = document.getElementById('colorSelect');
        const selectedIndex = select.selectedIndex;
        if (selectedIndex >= 0) {
            select.remove(selectedIndex);
        }
    });

// - Modificar imagen cuando entre el mouse
const img = document.getElementById('imagenGato');
img.addEventListener('mouseenter', () => {
    const max = 600;
    const min = 300;
    const width = Math.floor(Math.random() * (max - min + 1) + min);
    const height = Math.floor(Math.random() * (max - min + 1) + min);
    const newSrc = `https://placekitten.com/${width}/${height}`;
    img.src = newSrc;
});