import React from 'react';
import {Card, Col, Image} from "react-bootstrap";
import {useNavigate} from "react-router-dom";
import {NFT_ROUTE} from "../utils/consts";
import eth from '../assets/eth.png'

const NftItem = ({nft}) => {
    const navigate = useNavigate()
    return (
        <Col md={4} className="mt-3" onClick={() => navigate(NFT_ROUTE + '/' + nft.id)}>
            <Card style={{width: 300, cursor: 'pointer'}} border={"light"}>
                <Image width={300} height={300} src={nft.img}/>

                <div className="text-black-50 mt-1 d-flex justify-content-between align-items-center">
                    <div>{nft.type}</div>
                    <div className="d-flex align-items-center">
                            <div>{nft.price}</div>
                            <Image width={20} src={eth} />
                    </div>
                </div>
                <div>{nft.name}</div>
            </Card>

        </Col>
    );
};

export default NftItem;