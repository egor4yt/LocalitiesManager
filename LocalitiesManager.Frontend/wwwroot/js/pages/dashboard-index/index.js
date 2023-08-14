import {getHouses} from "./api/getHouses.js";
import {TableRow} from "./components/TableRow.js";

export function renderPage(options) {
    
    getHouses(0, 20, (houses) => {
        houses.forEach(x => new TableRow({
            house: x,
            tableBody: document.getElementById("table-body")
        }));
    })
}