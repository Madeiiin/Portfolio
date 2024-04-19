import React, {useContext} from 'react';
import {observer} from "mobx-react-lite";
import {Context} from "../index";
import {Card, Row} from "react-bootstrap";

const CollectionsBar = observer(() => {
    const {nft} = useContext(Context)
    return (
        <Row className="d-flex flex-row flex-nowrap" >
            {nft.collections.map(collection =>
              <Card
              style={{cursor: 'pointer'}}
              key={collection.id}
              className="p-3 flex-shrink-1"
              onClick={() => nft.setSelectedCollection(collection)}
              border={collection.id === nft.selectedCollection.id ? 'primary' : ''}
              >
                  {collection.name}
              </Card>
            )}

        </Row>

    );
});

export default CollectionsBar;