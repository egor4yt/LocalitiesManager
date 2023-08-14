export class DomHelper {
    static createElementFromHTML(htmlString) {
        if (htmlString.startsWith("<tr")) {
            const table = document.createElement('table');
            table.innerHTML = htmlString;

            return table.querySelector("tr");
        }
        
        const div = document.createElement('div');
        div.innerHTML = htmlString.trim();

        return div.firstChild;
    }
}