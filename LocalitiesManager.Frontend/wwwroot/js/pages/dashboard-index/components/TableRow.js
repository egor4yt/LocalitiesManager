import {DomHelper} from "../../../helpers/DomHelper.js";
import {House} from "../entities/House.js";

export class TableRow {
    house = null;
    elements = {
        rootElement: null,
        tableBody: null
    };

    constructor(options) {
        this.house = new House(options.house);
        this.elements.tableBody = options.tableBody;

        this.#initializeElement();
    }

    #initializeElement() {
        const template = `<tr>
                               <td>${this.house.localityPrefix} ${this.house.localityName}</td>
                               <td>${this.house.streetPrefix} ${this.house.streetName}, ${this.house.number}</td>
                               <td>${this.house.apartmentsCount}</td>
                               <td>
                                   <div>
                                       <button class="btn btn-primary">Редактировать</button>
                                   </div>
                               </td>
                           </tr>`;
        
        this.elements.rootElement = DomHelper.createElementFromHTML(template);
        this.elements.tableBody.appendChild(this.elements.rootElement);
    };
}