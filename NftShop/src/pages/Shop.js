import React from 'react';
import {Button, Col, Container, Row} from "react-bootstrap";
import TypeBar from "../components/TypeBar";
import CollectionsBar from "../components/CollectionsBar";
import NftList from "../components/NftList";

const Shop = () => {
    return (
        <Container>
            <Row className="mt-2">
                <Col md={3}>
                    <TypeBar/>
                </Col>

                <Col md={9}>
                    <CollectionsBar/>
                    <NftList/>
                </Col>
            </Row>
        </Container>
    );
};

export default Shop;