import {makeAutoObservable} from "mobx";

export default class NftStore {
    constructor() {

       this._types = [
           {id: 1, name: 'Gif'},
           {id: 2, name: 'Image'},
       ]

        this._collections = [
            {id: 1, name: 'Russian'},
            {id: 2, name: 'Animals'},
            {id: 3, name: 'Rofl'},
        ]

        this._nfts = [
            {id: 1, name: 'Monke', price: 0.1, type: "gif", img: 'https://c.tenor.com/NVek9cmNvAUAAAAM/mad-monkey.gif'},
            {id: 2, name: 'russian', price: 0.1, type: "image", img: 'https://i.mycdn.me/i?r=AzEPZsRbOZEKgBhR0XGMT1RksLypGs2zhW83uDy6mBAKuaaKTM5SRkZCeTgDn6uOyic&fn=sqr_288'},
            {id: 3, name: 'JOKE', price: 0.0033, type: "image", img: 'https://i.pinimg.com/originals/62/2a/c3/622ac3681a95fea685aa3733e01604b5.jpg'},
            {id: 4, name: 'nftRofl', price: 0.456, type: "image", img: 'https://pbs.twimg.com/media/E-_pCBwX0AkcR47?format=jpg&name=large'},
            {id: 5, name: 'russian', price: 0.0006, type: "image", img: 'https://i.mycdn.me/i?r=AzEPZsRbOZEKgBhR0XGMT1RksLypGs2zhW83uDy6mBAKuaaKTM5SRkZCeTgDn6uOyic&fn=sqr_288'},
            {id: 6, name: 'JOKE', price: 0.0023, type: "image", img: 'https://i.pinimg.com/originals/62/2a/c3/622ac3681a95fea685aa3733e01604b5.jpg'},
            {id: 7, name: 'nftRofl', price: 1, type: "image", img: 'https://pbs.twimg.com/media/E-_pCBwX0AkcR47?format=jpg&name=large'},
        ]

        this._selectedType = {}
        this._selectedColletion = {}
        makeAutoObservable(this)
    }

    setTypes(types) {
        this._types = types
    }

    get types() {
        return this._types
    }

    setNfts(nfts) {
        this._nfts = nfts
    }

    get nfts() {
        return this._nfts

    }

    setCollections(collections) {
        this._collections = collections
    }

    get collections() {
        return this._collections
    }


    setSelectedType(type) {
        this._selectedType = type
    }

    setSelectedCollection(collection) {
        this._selectedColletion = collection
    }

    get selectedType() {
        return this._selectedType
    }

    get selectedCollection() {
        return this._selectedColletion
    }


}
