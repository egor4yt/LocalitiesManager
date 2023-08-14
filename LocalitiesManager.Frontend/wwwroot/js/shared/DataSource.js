import {ServerFilteringSettings} from "./ServerFilteringSettings.js";
import {DataSourceItem} from "./DataSourceItem.js";

export class DataSource {
    #data = [];
    serverFiltering = null;
    onchange = null;
    initialData = [];

    constructor(options) {
        if (!options) options = [];
        if (options.data && options.data instanceof Array) {
            this.#data = this.initialData = options.data.map(el => new DataSourceItem({...el}));
        }

        if (options.serverFiltering) this.serverFiltering = new ServerFilteringSettings(options.serverFiltering);
        if (options.onchange && options.onchange instanceof Function) this.onchange = options.onchange;
    }

    /*
     * get all elements in data source
     * @returns {Array.<DataSourceItem>} all items in data source
     */
    getData() {
        return this.#data;
    }

    /*
     * set new data source
     * @param {Array} newData - new items for data source
     * @returns {Array.<DataSourceItem>} all items in data source
     */
    setData(newData) {
        if (!(newData instanceof Array)) throw TypeError("New data must be array");

        this.#data = newData.map(el => new DataSourceItem({...el}));

        this.#change();
        return this.#data;
    }

    /*
    * set new initial data source
    * @param {Array} newData - new items for data source
    * @returns {Array.<DataSourceItem>} all items in data source
    */
    resetInitialData(newData) {
        if (!(newData instanceof Array)) throw TypeError("New data must be array");
        this.initialData = newData.map(el => new DataSourceItem({...el}));

        this.setData(newData)
    }

    /*
     * refresh data source working only if for server filtering
     */
    refresh() {
        if (!this.serverFiltering) return;
        this.serverFiltering.filter((serverFilteringResponse) => this.setData(serverFilteringResponse.items))
    }

    /*
     * push new element to data source
     * @param {Object} element - new item for data source
     */
    add(element) {
        const newDataSourceItem = new DataSourceItem({...element});
        this.#data.push(newDataSourceItem);
        this.#change();
    }

    #change() {
        if (this.onchange) this.onchange(this.#data);
    }
}