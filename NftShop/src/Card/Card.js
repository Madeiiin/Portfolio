import React from "react";
import {Link} from "react-router-dom";
import favorite from "../assets/favorite.png";
import deleteFavorite from "../assets/deleteFavorite.png";

let a = 0;

function Card({ item }) {
    const handleClick = (event) => {
        event.target.style.visibility = "hidden"
        localStorage.setItem(item.id, JSON.stringify([item.title]))

    }
    const handleClickDelete = (event) => {
        event.target.style.visibility = "hidden"
        localStorage.removeItem(item.id, JSON.stringify([item.title]))
    }
    return(
        <div className="cal" id={item.id}>
            <div className="cal-info">
                <Link to={"/News/" + item.id}>
                    <h3>{item.title }</h3>
                </Link>
                <h4>{item.newsSite}</h4>
                <div className="meta">
                    <h6>{item.id} ... </h6>
                    <h6> posted {item.publishedAt.slice(0,10)}</h6>
                </div>
            </div>
            <div className="cal-img">
                <img className="calmg" src={item.imageUrl}/>
            </div>
        </div>
    );
}
export default Card;