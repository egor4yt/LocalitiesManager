export class ServerFilteringSchema {
    totalCountPropertyName = 'count';
    itemsPropertyName = 'items';


    constructor(options) {
        if (!options) options = {};

        if (options.count) this.totalCountPropertyName = options.count;
        if (options.items) this.itemsPropertyName = options.items;
    }
}