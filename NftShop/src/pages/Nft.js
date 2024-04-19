import React from 'react';
import {Button, Card, Col, Container, Image, Row} from "react-bootstrap";
import eth from "../assets/eth.png";
import {NFT_ROUTE} from "../utils/consts";
const Nft = () => {

       let nft;
        switch (window.location.href) {
            case "http://localhost:3000/nft/1":
                 nft =  {id: 1, name: 'Monke', price: 0.1, type: "gif", img: 'https://c.tenor.com/NVek9cmNvAUAAAAM/mad-monkey.gif'};
                break;
            case "http://localhost:3000/nft/2":
                nft =  {id: 2, name: 'russian', price: 0.1, type: "image", img: 'https://i.mycdn.me/i?r=AzEPZsRbOZEKgBhR0XGMT1RksLypGs2zhW83uDy6mBAKuaaKTM5SRkZCeTgDn6uOyic&fn=sqr_288'};
                break;
            case "http://localhost:3000/nft/3":
                nft =  {id: 3, name: 'JOKE', price: 0.0033, type: "image", img: 'https://i.pinimg.com/originals/62/2a/c3/622ac3681a95fea685aa3733e01604b5.jpg'};
                break;
            case "http://localhost:3000/nft/4":
                nft =  {id: 4, name: 'nftRofl', price: 0.456, type: "image", img: 'https://pbs.twimg.com/media/E-_pCBwX0AkcR47?format=jpg&name=large'};
                break;
            case "http://localhost:3000/nft/5":
                nft =  {id: 5, name: 'russian', price: 0.0006, type: "image", img: 'https://i.mycdn.me/i?r=AzEPZsRbOZEKgBhR0XGMT1RksLypGs2zhW83uDy6mBAKuaaKTM5SRkZCeTgDn6uOyic&fn=sqr_288'};
                break;
            case "http://localhost:3000/nft/6":
                nft =  {id: 6, name: 'JOKE', price: 0.0023, type: "image", img: 'https://i.pinimg.com/originals/62/2a/c3/622ac3681a95fea685aa3733e01604b5.jpg'};
                break;
            case "http://localhost:3000/nft/7":
                nft =  {id: 7, name: 'nftRofl', price: 1, type: "image", img: 'https://pbs.twimg.com/media/E-_pCBwX0AkcR47?format=jpg&name=large'};
                break;

        }


    return (
        <Container className="mt-4">
            <Row>
            <Col md={5}>
                <Image width={500} height={500} src={nft.img}/>
            </Col>
            <Col md={4}>
                <h1>{nft.name}</h1>

                <Card className={"p-1"}>
                    <div>
                    <h3 style={{display: "block", float: "left"}}>{nft.price}</h3>
                    <Image width={30} height={40} src={eth}  style={{display: "inline-block"}}/>
                    </div>
                    <Button variant={"outline-primary"}>Купить</Button>
                </Card>
            </Col>
            </Row>
        </Container>
    );
};

export default Nft;