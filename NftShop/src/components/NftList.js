import React, {useContext} from 'react';
import {observer} from "mobx-react-lite";
import {Context} from "../index";
import {Row} from "react-bootstrap";
import NftItem from "./NftItem";

const NftList = observer(() => {
    const {nft} = useContext(Context)
    return (
        <Row className="d-flex">

            {nft.nfts.map(nft =>
                <NftItem key={nft.id} nft={nft}/>
            )}
        </Row>
    );
});

export default NftList;